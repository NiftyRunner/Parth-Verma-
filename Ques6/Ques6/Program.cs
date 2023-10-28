/*Define a class Employee with data members: employee name, city, basic salary, 
dearness allowance (DA%) and house rent (HRA%). 
Define getdata(), calculate(), and display() functions.

Calculate method should find the total salary and display method 
should display it. (Total = basic+basic*da/100+basic*hra/100;)*/

using Ques6;

Employee employee1 = new Employee("Parth", "Gurgaon", 2400000, 2100, 5600);

void GetData()
{
    string name = employee1.GetName();
    string city = employee1.GetCity();
    int basic = employee1.GetBasicSalary();
    int hra = employee1.GetHRent();
    int da = employee1.GetDa();
}

void Calculate()
{
    
}

void Display()
{

}

