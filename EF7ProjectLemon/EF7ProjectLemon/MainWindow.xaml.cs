using System;
using System.Collections.Generic;
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

namespace EF7ProjectLemon
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            using (var db = new LemonContext())
            {
                
                db.People.Add(new Person { Name = "Саша" });
                db.SaveChanges();

                db.AuthPeople.Add(new Auth { Login = "avdridger" });
                db.SaveChanges();


                string name = null;

                foreach (var person in db.People)
                {
                    MessageBox.Show("А вот и " + person.Name);
                    name = person.Name;
                }

                foreach (var auth in db.AuthPeople)
                {
                    MessageBox.Show("логин у "+ name + " :" + auth.Login);
                }
            }


            MessageBox.Show("если долго мучится что нибудь получится");
        }
    }
}
