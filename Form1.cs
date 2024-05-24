using System.Windows.Forms;

namespace Kp
{
    public partial class Form1 : Form
    {
        private ChildQueue childQueue; // Объявляем переменную как член класса

        public Form1()
        {
            InitializeComponent();
            childQueue = new ChildQueue(); // Инициализируем переменную в конструкторе
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = childQueue.Children;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int age = Convert.ToInt32(textBox2.Text);
            Gender gender = (Gender)comboBox1.SelectedIndex; // Предполагается, что comboBox1 содержит значения Male и Female
            DateTime enrollmentDate = dateTimePicker1.Value;
            int groupNumber = Convert.ToInt32(textBox3.Text);

            Child newChild = new Child(name, age, gender, enrollmentDate, groupNumber);
            childQueue.AddChild(newChild);
            RefreshDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Удаление выбранного ребенка из очереди
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Child selectedChild = (Child)dataGridView1.SelectedRows[0].DataBoundItem;
                childQueue.RemoveChild(selectedChild);
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Полная очистка очереди
            childQueue.ClearQueue();
            RefreshDataGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Сохранение данных в файл
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary files (*.bin)|*.bin";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                childQueue.SaveToFile(saveFileDialog.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}