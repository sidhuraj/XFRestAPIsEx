using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestAPIEx
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmpRegistrationPage : ContentPage
    {
        public EmpRegistrationPage()
        {
            InitializeComponent();

            btnAddEmp.Clicked += BtnAddEmp_Clicked;
        }

        private async void BtnAddEmp_Clicked(object sender, EventArgs e) //after getting the clicked then add async "because await will works" 
            
        {
            Employee objEmployee = new Employee();//OBJECT CREATE//
            objEmployee.name = etEmpName.Text;
            objEmployee.salary = etEmpSalary.Text;
            objEmployee.age = etEmpAge.Text;


            HttpClient objHttpClient = new HttpClient();

            var content = JsonConvert.SerializeObject(objEmployee);



          // var empData = new StringContent(content, Encoding.UTF8, "application/json");

            var httpContent = new StringContent(content, Encoding.UTF8, "application/json");



           var response = await objHttpClient.PostAsync("http://dummy.restapiexample.com/api/v1/create", httpContent);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();


            }
            else
            {
                
            }
        }
    }
}
//This url is write is workiing//