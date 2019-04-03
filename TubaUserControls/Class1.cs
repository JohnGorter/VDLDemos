using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TubaUserControls
{

    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class ExampleIDesigner : System.ComponentModel.Design.IDesigner
    {
        // Local reference to the designer's component.
        private IComponent component;
        // Public accessor to the designer's component.
        public System.ComponentModel.IComponent Component
        {
            get
            {
                return component;
            }
        }

        public ExampleIDesigner()
        {
        }

        public void Initialize(System.ComponentModel.IComponent component)
        {
            // This method is called after a designer for a component is created,
            // and stores a reference to the designer's component.
            this.component = component;
        }

        // This method peforms the 'default' action for the designer. The default action 
        // for a basic IDesigner implementation is invoked when the designer's component 
        // is double-clicked. By default, a component associated with a basic IDesigner 
        // implementation is displayed in the design-mode component tray.
        public void DoDefaultAction()
        {
            // Shows a message box indicating that the default action for the designer was invoked.
            MessageBox.Show("The DoDefaultAction method of an IDesigner implementation was invoked.", "Information");
        }

        // Returns a collection of designer verb menu items to show in the 
        // shortcut menu for the designer's component.
        public System.ComponentModel.Design.DesignerVerbCollection Verbs
        {
            get
            {
                DesignerVerbCollection verbs = new DesignerVerbCollection();
                DesignerVerb dv1 = new DesignerVerb("Display Component Name", new EventHandler(this.ShowComponentName));
                verbs.Add(dv1);
                return verbs;
            }
        }

        // Event handler for displaying a message box showing the designer's component's name.
        private void ShowComponentName(object sender, EventArgs e)
        {
            if (this.Component != null)
                MessageBox.Show(this.Component.Site.Name, "Designer Component's Name");
        }

        // Provides an opportunity to release resources before object destruction.
        public void Dispose()
        {
        }
    }

    [Designer(typeof(ExampleIDesigner), typeof(IRootDesigner))]
    public class MyControl : Control
    {
        [Browsable(true)]
        [Category("category")]
        public Color color { get; set; }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            Invalidate();
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
           
            base.OnPaint(e);
            Graphics g = Graphics.FromHwnd(this.Handle);
            Pen p = new Pen(Focused ? Brushes.Red : new SolidBrush(color));
            g.FillEllipse(Focused ? Brushes.Red : new SolidBrush(color), e.ClipRectangle);


        }
    }

    public class VDLGrid : DataGrid {

    }

    public class VDLTextBox : TextBox {
        protected override void InitLayout()
        {
            base.InitLayout();

            if (ConfigurationManager.AppSettings["vdlcolor"] != null)
                this.BackColor = Color.FromName(ConfigurationManager.AppSettings["vdlcolor"]);
            else
                this.BackColor = Color.Red;
        }
    }
}
