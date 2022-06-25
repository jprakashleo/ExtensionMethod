using ExtensionMethod;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("JAIPRkash".ToProperCase());
Console.WriteLine("hardik punjabi".ToProperCase());

List<CityStates> RTOlist = new List<CityStates>();

CityStates citys = new CityStates();

citys.Id = 14;
citys.City = "Jaipur";
citys.State = "Rajasthan";
RTOlist.Add(citys);

CityStates citys1 = new CityStates();
citys1.Id = 13;
citys1.City = "Ganganagar";
citys1.State = "Rajasthan";
RTOlist.Add(citys1);

CityStates citys2 = new CityStates();
citys2.Id = 19;
citys2.City = "Jodhpur";
citys2.State = "Rajasthan";
RTOlist.Add(citys2);

CityStates citys3 = new CityStates();
citys3.Id = 15;
citys3.City = "Jaiselmer";
citys3.State = "Rajasthan";
RTOlist.Add(citys3);

Console.WriteLine(RTOlist[0].City + "  " + RTOlist[1].City + "  " + RTOlist[2].City);

var d = RTOlist.ToDatatable();

for(int i = 0; i < d.Rows.Count; i++)
{
    Console.WriteLine(d.Rows[i]["id"].ToString() + "  " + d.Rows[i]["city"].ToString() +" " + d.Rows[i]["state"].ToString());
}
Console.ReadKey();
public class CityStates
{
    public int Id { get; set; }
    public string City { get; set; }
    public string State { get; set; }

}