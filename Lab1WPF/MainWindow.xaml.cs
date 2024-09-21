using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lab1Library;

namespace Lab1WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Studentu saraksts.
        /// </summary>
        private StudentsData students = new StudentsData();

        private void InvalidateList()
        {
            // saraksta aktualizēšana
            lstStudents.ItemsSource = students.Students.ToList();
        }

        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                students.Add(new Student(txtName.Text, txtSurname.Text
                    , txtId.Text, txtGroup.Text, txtEmail.Text));
                InvalidateList();
                txtName.Clear();
                txtSurname.Clear();
                txtId.Clear();
                txtGroup.Clear();
                txtEmail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                students.Save(StudentsData.DefaultFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                students.Students.Clear();
                students.Load(StudentsData.DefaultFilename);
                InvalidateList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}