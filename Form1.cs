namespace Planets_WF
{
    public partial class Form1 : Form
    {
        int total = 0;

        enum Planets
        {
            Меркурій=3,Венера=48,Земля=59,Марс=6,Юпітер=18980,Сатурн=5683,Уран=868,Нептун=1024
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string planet = textBox1.Text;

            switch (planet)
            {
                case "Меркурій":
                    total += (int)Planets.Меркурій;
                    break;
                case "Венера":
                    total += (int)Planets.Венера;
                    break;
                case "Земля":
                    total += (int)Planets.Земля;
                    break;
                case "Марс":
                    total += (int)Planets.Марс;
                    break;
                case "Юпітер":
                    total += (int)Planets.Юпітер;
                    break;
                case "Сатурн":
                    total += (int)Planets.Сатурн;
                    break;
                case "Уран":
                    total += (int)Planets.Уран;
                    break;
                case "Нептун":
                    total += (int)Planets.Нептун;
                    break;
                default:
                    label2.Text = "Помилка вводу";
                    return;
            }
            label2.Text = "Додано успішно";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = total + " * 10^23 кг";
        }
    }
}