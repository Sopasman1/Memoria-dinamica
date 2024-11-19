namespace Memoria_dinamica
{
    public partial class Form1 : Form
    {
        private List<int> numbers;
        public Form1()
        {
            InitializeComponent();
            numbers = new List<int>();
        }

        private void BtnAddNumber_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtNumber.Text, out int number))
            {
                // Agregamos el número a la lista dinámica
                numbers.Add(number);

                // Actualizamos la lista en el ListBox
                listNumber.Items.Add(number);

                // Limpiamos el TextBox
                TxtNumber.Clear();
                TxtNumber.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Calculamos la suma de los números en la lista
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            // Mostramos la suma en un MessageBox
            MessageBox.Show($"La suma de los números es: {sum}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
