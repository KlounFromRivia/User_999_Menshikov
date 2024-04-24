using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Techno.Context;
using Techno.Context.Models;

namespace Techno.UI
{
    public partial class MainOrderForm : Form
    {
        public MainOrderForm()
        {
            InitializeComponent();
            ToolTip tl = new ToolTip();
            tl.SetToolTip(btnAddOrder,"КНОПКА, ЖМИ");
            List<Order> listOrder;
            switch(CurrectUser.User.RoleId)
            {
                case 1: lblUser.Text = "Окно клиента";
                    btnAddOrder.Enabled = true;
                    btnAddOrder.Visible = true;
                    using(var db = new TechnoDBContext())
                    {
                        listOrder = db.Orders
                            .Include(x => x.Client)
                            .Include(x => x.Master)
                            .Include(x => x.Status)
                            .Include(x => x.TypeEquipment)
                            .Where(x => x.ClientId == CurrectUser.User.IdUser)
                            .ToList();
                    }
                    break;
                case 2:
                    lblUser.Text = "Окно мастера";
                    using (var db = new TechnoDBContext())
                    {
                        listOrder = db.Orders
                            .Include(x => x.Client)
                            .Include(x => x.Master)
                            .Include(x => x.Status)
                            .Include(x => x.TypeEquipment)
                            .Where(x => x.MasterId == CurrectUser.User.IdUser)
                            .ToList();
                    }
                    break;
                case 3:
                    lblUser.Text = "Окно оператора";
                    using (var db = new TechnoDBContext())
                    {
                        listOrder = db.Orders
                            .Include(x => x.Client)
                            .Include(x => x.Master)
                            .Include(x => x.Status)
                            .Include(x => x.TypeEquipment)
                            .ToList();
                    }
                    break;

                default:
                    lblUser.Text = "Окно менеджера";
                    using (var db = new TechnoDBContext())
                    {
                        listOrder = db.Orders
                            .Include(x => x.Client)
                            .Include(x => x.Master)
                            .Include(x => x.Status)
                            .Include(x => x.TypeEquipment)
                            .ToList();
                    }
                    break;
            }
            foreach(var order in listOrder)
            {
                AddOrderView(order);
            }
        }
        public void AddOrderView(Order order)
        {
            var orderControl = new OrderView(order);
            orderControl.Parent = flowLayoutPanel1;
            orderControl.StatusCount += OrderControl_StatusCount;
            CompletedCount();
        }

        public void CompletedCount()
        {
            int countStatus = 0;
            foreach (var status in flowLayoutPanel1.Controls)
            {
                if(status is OrderView controlOrder)
                {
                    if(controlOrder.Order.StatusId ==3)
                    {
                        countStatus++;
                    }
                }
            }
            tssStatus.Text = "Статус Выполнено: "+countStatus.ToString();
        }

        private void OrderControl_StatusCount()
        {
            CompletedCount();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            using (var db = new TechnoDBContext())
            {
                var order = new Order()
                {
                    CreateOrder = DateTime.Now,
                    ModelEquipment = "Модель",
                    DescriptionDefect = "Описание поломки",
                    StatusId = 1,
                    TypeEquipmentId = 1,
                    ClientId = CurrectUser.User.IdUser,
                };
                db.Orders.Add(order);
                db.SaveChanges();
                var controlOrder = new OrderView(db.Orders
                    .Include(x => x.Client)
                    .Include(x => x.Master)
                    .Include(x => x.Status)
                    .Include(x => x.TypeEquipment)
                    .FirstOrDefault(x => x.IdOrder == db.Orders.Max(y => y.IdOrder)));
                controlOrder.Parent = flowLayoutPanel1;
            }
        }
    }
}
