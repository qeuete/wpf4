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
using System.Windows.Shapes;
using System.Xml.Linq;
using System.Xml.Serialization;
using static WpfApp1.EditPage;

namespace WpfApp1
{
    public partial class User : Window
    {
        private bool isEditor;
        private string testFilePath;
        private Test test;
        public User()
        {
            InitializeComponent();
            this.isEditor = isEditor;
            this.testFilePath = testFilePath;
            EditTest.IsEnabled = isEditor;

            LoadTest();
        }
        private void LoadTest()
        {
            if (File.Exists(testFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Test));
                using (FileStream fs = new FileStream(testFilePath, FileMode.Open))
                {
                    test = (Test)serializer.Deserialize(fs);
                    DataContext = test;
                }
            }
            else
            {
                test = new Test();
                DataContext = test;
            }
        }
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new EditPage(test, testFilePath);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(testFilePath) || VoidFile(testFilePath))
            {
                PageFrame.Content = new PustoPage();
            }
            else
            {
                PageFrame.Content = new StartPage(test.Questions);
            }
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            SaveTest();
            this.Close();
        }
        private void SaveTest()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Test));
            using (FileStream fs = new FileStream(testFilePath, FileMode.Create))
            {
                serializer.Serialize(fs, test);
            }
        }
        private void User_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveTest();
        }
        private bool VoidFile(string filePath)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(filePath);

                XElement questionsElement = xmlDoc.Root.Element("Questions");

                return questionsElement == null || !questionsElement.HasElements;
            }
            catch (Exception)
            {
                return true;
            }
        }

    }
}
