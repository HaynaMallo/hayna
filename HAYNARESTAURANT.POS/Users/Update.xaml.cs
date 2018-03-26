using HAYNARESTAURANT.Domain.BBL;
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

namespace HAYNARESTAURANT.POS.Users
{
    /// <summary>
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        private HAYNARESTAURANT.Domain.Models.Users _users;
        private User.List _sender;

        public Update(HAYNARESTAURANT.Domain.Models.Users users, User.List sender)
        {
            InitializeComponent();  

            this.txtFirstname.Text = users.FirstName;
            this.txtLastname.Text = users.LastName;
            this.txtUsername.Text = users.UserName;
            this._users = users;
            this._sender = sender;

            cboRole.ItemsSource = Enum.GetValues(typeof(Role)).Cast<Role>().ToList();
            cboRole.SelectedValue = users.Role;
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
                users.Id = this._users.Id;
                UsersBLL.Create(users);
                MessageBox.Show("User successfully created.");
                this._sender.showList();
                this.Close();
            }
        }


        private bool Validate()
        {
            if (string.IsNullOrEmpty(txtUsername.Text) ||
               string.IsNullOrEmpty(txtFirstname.Text) ||
               string.IsNullOrEmpty(txtLastname.Text) ||
               cboRole.SelectedValue == null)
            {
                MessageBox.Show("Please input correct values");
                return false;
            };

            return true;
                
        }
    }
}
