using Syncfusion.ListView.XForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Swiping
{
    public partial class SfPopUpView : ContentPage
    {
        #region Fields
        public string TitleText;
        public string DescriptionText;
        public string SubjectText;
        public string DateText;
        #endregion

        #region Properties
        
        #endregion

        #region constructor
        public SfPopUpView()
        {
            InitializeComponent();
            this.BindingContextChanged += SfPopUpView_BindingContextChanged;
        }

        private void SfPopUpView_BindingContextChanged(object sender, EventArgs e)
        {
            TitleText = titleeditor.Text;
            DescriptionText = desceditor.Text;
            SubjectText = subeditor.Text;
            DateText = dateeditor.Text;
        }
        
        private void savebtn_clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private void cancelbtn_clicked(object sender, EventArgs e)
        {
            titleeditor.Text = TitleText;
            desceditor.Text = DescriptionText;
            subeditor.Text = SubjectText;
            dateeditor.Text = DateText;
            Navigation.PopAsync();
        }
        #endregion
    }
}
