using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OneDriveFileSaveAndLoadTest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataPage : ContentPage
	{
        private string fileName, dataToFile;
		public DataPage ()
		{
			InitializeComponent ();
		}

        private void NameFile_Completed(object sender, EventArgs e)
        {
            fileName = e.ToString();
        }

        private void DataToFile_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            dataToFile = e.ToString();
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            if (fileName != null && dataToFile != null)
            {

            }
            else DisplayAlert("Error", "File doesn't have a name or text to save", "Cancel");
        }
    }
}