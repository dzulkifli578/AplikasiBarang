using AplikasiBarang.Barang;
using System.Collections;
using System.Data;
using System.Text.Json;
using System.Windows.Forms;

namespace AplikasiBarang
{
    public partial class BarangView : Form
    {
        int indexStatus = 0;
        public BarangView()
        {
            InitializeComponent();
            dapatkanDataBarang();
        }

        private async void buttonTambah_Click(object sender, EventArgs e)
        {
            BarangModel.Nama = textBoxNama.Text;
            BarangModel.Harga = textBoxNama.Text;
            BarangModel.Status = indexStatus;

            bool status = await BarangController.TambahBarang();
            if (status)
            {
                dapatkanDataBarang();
                bersihkanSemuaInput();
            }
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            BarangModel.Id = Convert.ToInt32(textBoxID.Text);
            BarangModel.Nama = textBoxNama.Text;
            BarangModel.Harga = textBoxHarga.Text;
            BarangModel.Status = indexStatus;

            bool status = await BarangController.EditBarang();
            if (status)
            {
                dapatkanDataBarang();
                bersihkanSemuaInput();
            }
        }

        private async void buttonHapus_Click(object sender, EventArgs e)
        {
            BarangModel.Id = Convert.ToInt32(textBoxID.Text);

            bool status = await BarangController.HapusBarang();
            if (status)
            {
                dapatkanDataBarang();
                bersihkanSemuaInput();
            }
        }

        private void dataGridViewBarang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxID.Text = Convert.ToString(dataGridViewBarang.Rows[e.RowIndex].Cells["id"].Value);
                textBoxNama.Text = Convert.ToString(dataGridViewBarang.Rows[e.RowIndex].Cells["nama"].Value);
                textBoxHarga.Text = Convert.ToString(dataGridViewBarang.Rows[e.RowIndex].Cells["harga"].Value);

                if (Convert.ToString(dataGridViewBarang.Rows[e.RowIndex].Cells["status"].Value) == "0")
                    comboBoxStatus.Text = "Tidak Tersedia";
                else
                    comboBoxStatus.Text = "Tersedia";
            }
        }

        private async void dapatkanDataBarang()
        {
            string endpoint = "http://127.0.0.1:8000/lihatbarang";

            try
            {
                string response = await ApiService.GetDataToApi(endpoint);
                var document = JsonDocument.Parse(response);

                if (document.RootElement.TryGetProperty("data", out JsonElement elementData) && elementData.GetArrayLength() > 0)
                {
                    // Membuat DataTable
                    DataTable dataTable = new DataTable();

                    // Menambahkan kolom ke DataTable
                    foreach (JsonProperty property in elementData[0].EnumerateObject())
                        dataTable.Columns.Add(property.Name);

                    // Mengisi DataTable dengan data JSON
                    foreach (JsonElement row in elementData.EnumerateArray())
                    {
                        DataRow dataRow = dataTable.NewRow();
                        foreach (JsonProperty property in row.EnumerateObject())
                            dataRow[property.Name] = property.Value.ToString();

                        dataTable.Rows.Add(dataRow);
                    }

                    dataGridViewBarang.DataSource = dataTable;
                    // ID
                    dataGridViewBarang.Columns["id"].Visible = true;
                    dataGridViewBarang.Columns["id"].DisplayIndex = 0;
                    dataGridViewBarang.Columns["id"].HeaderText = "ID";
                    // Nama
                    dataGridViewBarang.Columns["nama"].Visible = true;
                    dataGridViewBarang.Columns["nama"].DisplayIndex = 1;
                    dataGridViewBarang.Columns["nama"].HeaderText = "Nama";
                    // Harga
                    dataGridViewBarang.Columns["harga"].Visible = true;
                    dataGridViewBarang.Columns["harga"].DisplayIndex = 2;
                    dataGridViewBarang.Columns["harga"].HeaderText = "Harga";
                    // Status
                    dataGridViewBarang.Columns["status"].Visible = true;
                    dataGridViewBarang.Columns["status"].DisplayIndex = 3;
                    dataGridViewBarang.Columns["status"].HeaderText = "Status";
                    // Created At
                    dataGridViewBarang.Columns["created_at"].Visible = false;
                    // Updated_at
                    dataGridViewBarang.Columns["updated_at"].Visible = false;
                }
                else MessageBox.Show("Properti data tidak ditemukan dalam API", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bersihkanSemuaInput()
        {
            textBoxID.ResetText();
            textBoxNama.ResetText();
            textBoxHarga.ResetText();
        }

        private void dataGridViewBarang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewBarang.Columns[e.ColumnIndex].Name == "status")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();
                    e.Value = status == "1" ? "Tersedia" : "Tidak Tersedia";
                    e.FormattingApplied = true;
                }

            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexStatus = comboBoxStatus.SelectedIndex;
        }
    }
}
