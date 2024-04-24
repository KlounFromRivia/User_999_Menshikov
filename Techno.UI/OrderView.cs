using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Techno.Context;
using Techno.Context.Models;

namespace Techno.UI
{
    public partial class OrderView : UserControl
    {
        public event Action StatusCount;
        public Order Order { get; set; }
        public OrderView(Order order)
        {
            InitializeComponent();
            this.Order = order;
            Initializity(order);
        }
        public void Initializity(Order order)
        {
            using (var db = new TechnoDBContext())
            {
                cmbMaster.DataSource = db.Users.Where(x => x.RoleId == 2).ToList();
                cmbMaster.DisplayMember = nameof(User.UserFIO);
                cmbMaster.ValueMember = nameof(User.IdUser);
                cmbMaster.SelectedItem = cmbMaster.Items.Cast<User>().FirstOrDefault(x => x.IdUser == order.MasterId);

                cmbStatus.DataSource = db.Statuses.ToList();
                cmbStatus.DisplayMember = nameof(Status.StatusTitle);
                cmbStatus.ValueMember = nameof(Status.IdStatus);
                cmbStatus.SelectedItem = cmbStatus.Items.Cast<Status>().FirstOrDefault(x => x.IdStatus == order.StatusId);

                cmbTypeEq.DataSource = db.TypeEquipments.ToList();
                cmbTypeEq.DisplayMember = nameof(TypeEquipment.TypeEquipmentTitle);
                cmbTypeEq.ValueMember = nameof(TypeEquipment.IdTypeEquipment);
                cmbTypeEq.SelectedItem = cmbTypeEq.Items.Cast<TypeEquipment>().FirstOrDefault(x => x.IdTypeEquipment == order.TypeEquipmentId);

                lblNomer.Text = order.IdOrder.ToString();
                lblDate.Text = order.CreateOrder.ToString();
                txtDefect.Text = order.DescriptionDefect;
                txtModel.Text = order.ModelEquipment;
                txtZapchasty.Text = order.Zapchasty;
                lblFio.Text = order.Client.UserFIO;
            }
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = !string.IsNullOrEmpty(txtDefect.Text)
                &&!string.IsNullOrEmpty(txtModel.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using(var db = new TechnoDBContext())
            {
                var order = db.Orders.FirstOrDefault(x => x.IdOrder == Order.IdOrder);
                if(order != null)
                {
                    order.CreateOrder = DateTime.Parse(lblDate.Text);
                    order.ModelEquipment = txtModel.Text;
                    order.DescriptionDefect = txtDefect.Text;
                    order.Zapchasty = txtZapchasty.Text;
                    order.StatusId = ((Status)cmbStatus.SelectedItem).IdStatus;
                    order.TypeEquipmentId = ((TypeEquipment)cmbTypeEq.SelectedItem).IdTypeEquipment;
                    if(cmbMaster.SelectedItem != null)
                    {
                        order.MasterId = ((User)cmbMaster.SelectedItem).IdUser;
                        if(order.StatusId <= 2)
                        {
                            order.StatusId = 2;
                            cmbStatus.SelectedItem = cmbStatus.Items.Cast<Status>().FirstOrDefault(x => x.IdStatus == 2);
                        }
                    }
                }
                db.SaveChanges();
                MessageBox.Show("Данные сохраненны","Сохранение изменений",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Order = order;
                StatusCount?.Invoke();
            }
        }

        private void OrderView_Load(object sender, EventArgs e)
        {
            grbClient.Enabled = CurrectUser.User.RoleId == 1;
            grpMaster.Enabled = CurrectUser.User.RoleId == 2;
            grpOper.Enabled = CurrectUser.User.RoleId == 3;
        }

        private void btnViewCom_Click(object sender, EventArgs e)
        {
            var cvf = new CommentViewForm(Order);
            cvf.ShowDialog();
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            var acf = new AddCommentForm();
            if(acf.ShowDialog() == DialogResult.OK)
            {
                var message = new Comment()
                {
                    Message = acf.Message,
                    MasterId = CurrectUser.User.IdUser,
                    OrderId = Order.IdOrder,
                };
                using (var db = new TechnoDBContext())
                {
                    db.Comments.Add(message);
                    db.SaveChanges();
                }
            }
        }
    }
}
