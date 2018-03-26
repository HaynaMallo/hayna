using HAYNARESTAURANT.Domain.BBL;
using HAYNARESTAURANT.Domain.Models;
using HAYNARESTAURANT.Domain.Models.Enums;
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
using System.Windows.Shapes;

namespace HAYNARESTAURANT.POS.User
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Window    
    {
        private User.List _sender;



        public Add(User.List sender)
        {
            InitializeComponent();
            cboRole.ItemsSource = Enum.GetValues(typeof(Role)).Cast<Role>().ToList();
            this._sender = sender;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (Validate() == false)
        {
            return;
         }
            
         if (UsersBLL.GetUserByUserName(txtUsername.Text) != null)
         {
        MessageBox.Show("Username is already used");
         }
         else
        {
                HAYNARESTAURANT.Domain.Models.Users users = new HAYNARESTAURANT.Domain.Models.Users();
                users.Id = Guid.NewGuid();
                users.UserName = txtUsername.Text;
                users.LastName = txtLastname.Text;
                users.FirstName = txtFirstname.Text;
                
                Role role = new Role();
                                if (cboRole.SelectedValue.ToString() == Role.Admin.ToString())
                                    {
                    role = Role.Admin;
                                   }
                                else if (cboRole.SelectedValue.ToString() == Role.Cashier.ToString())
                                    {
                    role = Role.Cashier;
                                    }
                                else if (cboRole.SelectedValue.ToString() == Role.Chef.ToString())
                                    {
                    role = Role.Chef;
                                    }
                                else if (cboRole.SelectedValue.ToString() == Role.InventoryController.ToString())
                                    {
                    role = Role.InventoryController;
                                    }
                                else if (cboRole.SelectedValue.ToString() == Role.Waiter.ToString())
                                    {
                    role = Role.Waiter;
                                    }
                
                users.Role = role;
                users.Password = this.RandomString(6);
                UsersBLL.Create(users);
                MessageBox.Show("User successfully created.");
                this._sender.showList();
                this.Close();
                            }
                    }

        private bool Validate()
        {
            if(string.IsNullOrEmpty(txtUsername.Text) ||
               string.IsNullOrEmpty(txtFirstname.Text) ||
               string.IsNullOrEmpty(txtLastname.Text) ||
               cboRole.SelectedValue == null)
            {
                MessageBox.Show("Please input correct values");
                return false;
            };

            return true;
        }

         private Random random = new Random();
         private string RandomString(int length)
         {
             const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
             return new string (Enumerable.Repeat(chars, length)
               .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnCancel_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
