using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class CommentViewForm : Form
    {
        public CommentViewForm(Order order)
        {
            InitializeComponent();
            using (var db = new TechnoDBContext())
            {
                dgvComment.DataSource = db.Comments.Where(x => x.OrderId == order.IdOrder)
                    .Select(x => new
                    {
                        MasterFI = x.Master.UserFIO,
                        Message = x.Message,
                    }).ToList();
            }
        }
    }
}
