using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    public enum CorrectAnswerEnum
    {
        Option1,
        Option2,
        Option3
    }
    public static class TestSerializer
    {
        public static void Serialize(Test test, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Test));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, test);
            }
        }

        public static Test Deserialize(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Test));
            using (TextReader reader = new StreamReader(filePath))
            {
                return (Test)serializer.Deserialize(reader);
            }
        }
    }

    public enum CorrectAnswer
    {
        Option1,
        Option2,
        Option3
    }

    public class TestQuestion
    {
        public string Question { get; set; }
        public string Description { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public CorrectAnswer CorrectAnswer { get; set; }
    }


    public class Test
    {

        public ObservableCollection<TestQuestion> Questions { get; set; }

        public Test()
        {
            Questions = new ObservableCollection<TestQuestion>();
        }
    }

    public partial class EditPage : Page
    {
        private Test test;
        private string testFilePath;

        public EditPage(Test test, string testFilePath)
        {
            InitializeComponent();
            this.test = test;
            this.testFilePath = testFilePath;
            DataContext = test;
        }
        private void TestGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Проверяем, что есть выбранные элементы
            if (TestGrid.SelectedItems != null && TestGrid.SelectedItems.Count > 0)
            {
                // Пример вывода выбранных элементов в консоль
                foreach (var selectedItem in TestGrid.SelectedItems)
                {
                    // Пример вывода информации о выбранном элементе в консоль
                    Console.WriteLine(selectedItem.ToString());
                }
            }
        }
    }
}