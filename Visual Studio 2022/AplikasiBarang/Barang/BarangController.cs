namespace AplikasiBarang.Barang
{
    public class BarangController : BarangModel
    {
        public static async Task<bool> TambahBarang()
        {
            string endpoint = "http://127.0.0.1:8000/tambahbarang";

            try
            {
                var json = new
                {
                    nama = Nama,
                    harga = Harga,
                    status = Status
                };

                string response = await ApiService.PostDataToApi(endpoint, json);
                MessageBox.Show($"Response: {response}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static async Task<bool> EditBarang()
        {
            string endpoint = "http://127.0.0.1:8000/editbarang";

            try
            {
                var json = new
                {
                    id = Id,
                    nama = Nama,
                    harga = Harga,
                    status = Status
                };

                string response = await ApiService.PutDataToApi(endpoint, json);
                MessageBox.Show($"Response: {response}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static async Task<bool> HapusBarang()
        {
            string endpoint = $"http://127.0.0.1:8000/hapusbarang?id={Id}";

            try
            {
                string response = await ApiService.DeleteDataToApi(endpoint);
                MessageBox.Show($"Response: {response}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
