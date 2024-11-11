namespace ПЗ__5_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*ОЧИСТКА ТЕКСТОВЫХ ПОЛЕЙ:*/
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            /*ЗАКРЫТИЕ ПРОГРАММЫ:*/
            this.Close();
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            /*ОБЪЯВЛЕНИЕ ПЕРЕМЕННЫХ:*/
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);


            /*ВЫЧИСЛЕНИЯ:*/
            //Сложение переменных "a" и "b"
            double c = a + b;

            //Нахождение площади "S"
            double s = a * b;

            //Нахождение периметра "P"
            double p = 2 * (a + b);



            /*ВЫВЕДЕНИЕ РЕЗУЛЬТАТОВ ВЫЧИСЛЕНИЙ*/
            //Результат сложение переменных "a" и "b"
            textBox3.Text = c.ToString();

            //Результат нахождения площади "S"
            textBox4.Text = s.ToString();

            //Результат нахождения периметра "P"
            textBox5.Text = p.ToString();


            /*ИЗМИНЕНИЕ ЦВЕТА ФОРМЫ ПРИ НАЖАТИИ НА КННОПКУ*/
            this.BackColor = Color.Tomato;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}
