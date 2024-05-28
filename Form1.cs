using iTextSharp.text.pdf;
using System.ComponentModel;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Text;

namespace Kp
{
  
       
        public partial class Kindergarden : Form
    {
        private ChildQueue childQueue; // Объявляем переменную как член класса
        public Kindergarden()
        {
            InitializeComponent();
            childQueue = new ChildQueue(); // Инициализируем переменную в конструкторе
            dataGridView1.DataSource = childBindingSource;
        }

  
        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = childQueue.Children;
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string name = textBox1.Text;
           
            if (!int.TryParse(textBox2.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }
            if (!int.TryParse(textBox3.Text, out int groupNumber) || groupNumber <= 0)
            {
                MessageBox.Show("Please enter a valid group number.");
                return;
            }
            Gender gender = (Gender)comboBox1.SelectedIndex; // Предполагается, что comboBox1 содержит значения Male и Female
            DateTime enrollmentDate = dateTimePicker1.Value;
            Child newChild = new Child(name, age, gender, enrollmentDate, groupNumber);
            childQueue.AddChild(newChild);
            RefreshDataGridView();
        }

        private void buttonD_Click(object sender, EventArgs e)
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary files (*.bin)|*.bin";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                childQueue.LoadFromFile(openFileDialog.FileName);
                RefreshDataGridView();
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string sortBy = comboBoxSortBy.SelectedItem.ToString();

            // Выполняем сортировку в соответствии с выбранным параметром
            switch (sortBy)
            {
                case "Name":
                    childQueue.Children = childQueue.Children.OrderBy(c => c.Name).ToList();
                    break;
                case "Age":
                    childQueue.Children = childQueue.Children.OrderBy(c => c.Age).ToList();
                    break;
                case "Gender":
                    childQueue.Children = childQueue.Children.OrderBy(c => c.Gender).ToList();
                    break;
                case "Enrollment Date":
                    childQueue.Children = childQueue.Children.OrderBy(c => c.EnrollmentDate).ToList();
                    break;
                case "Group number":
                    childQueue.Children = childQueue.Children.OrderBy(c => c.GroupNumber).ToList();
                    break;
                default:
                    break;
            }
            // Обновляем отображение в DataGridView
            RefreshDataGridView();
            dataGridView1.Refresh(); // Обновляем таблицу
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchName = textBoxSearch.Text;
            var results = childQueue.Children.Where(c => c.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase)).ToList();
            if (results.Any())
            {
                StringBuilder messageBuilder = new StringBuilder();
                foreach (var result in results)
                {
                    messageBuilder.AppendLine($"Name: {result.Name}");
                    messageBuilder.AppendLine($"Age: {result.Age}");
                    messageBuilder.AppendLine($"Gender: {result.Gender}");
                    messageBuilder.AppendLine($"Enrollment Date: {result.EnrollmentDate}");
                    messageBuilder.AppendLine($"Group Number: {result.GroupNumber}");
                    messageBuilder.AppendLine("-----------------------------------");
                }

                MessageBox.Show(messageBuilder.ToString(), "Child Information");
            }
            else
            {
                MessageBox.Show("Child not found.");
            }
        }


        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxFilterAge.Text, out int filterAge))
            {
                var filteredChildren = childQueue.Children.Where(c => c.Age == filterAge).ToList();
                dataGridView1.DataSource = filteredChildren;
            }
            else
            {
                MessageBox.Show("Please enter a valid age for filtering.");
            }
        }

        private void buttonExportPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToPdf(saveFileDialog.FileName);
            }
        }

        private void ExportToPdf(string filePath)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            PdfPTable table = new PdfPTable(5);
            table.AddCell("Name");
            table.AddCell("Age");
            table.AddCell("Gender");
            table.AddCell("Enrollment Date");
            table.AddCell("Group Number");

            foreach (var child in childQueue.Children)
            {
                table.AddCell(child.Name);
                table.AddCell(child.Age.ToString());
                table.AddCell(child.Gender.ToString());
                table.AddCell(child.EnrollmentDate.ToShortDateString());
                table.AddCell(child.GroupNumber.ToString());
            }

            document.Add(table);
            document.Close();
        }

        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            comboBoxSortBy.SelectedIndex = -1; // Сброс сортировки
            textBoxFilterAge.Text = ""; // Сброс фильтра по возрасту

            // Обновление DataGridView
            RefreshDataGridView();
        }

     
    }
}