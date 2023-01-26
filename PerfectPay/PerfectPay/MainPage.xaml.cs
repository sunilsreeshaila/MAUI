namespace PerfectPay;

public partial class MainPage : ContentPage
{
    private decimal bill;
    private int tip;
    private int noPersons = 1;

	public MainPage()
	{
		InitializeComponent();
	}

    private void txtBill_Completed(object sender, EventArgs e)
    {
        bill = decimal.Parse(txtBill.Text);
        CalculateTotal();
    }

    private void CalculateTotal()
    {
        //Total Tip
        var totalTip = (bill * tip) / 100;

        //Tip By Person
        var tipByPerson = totalTip / noPersons;
        lblTipByPerson.Text = $"{tipByPerson:C}";

        //SubTotal
        var subtotal = bill / noPersons;
        lblSubTotal.Text = $"{subtotal:C}";

        //Total
        var totalByPerson = (bill + totalTip) / noPersons;
        lblTotal.Text = $"{totalByPerson:C}";
    }

    private void sliderTip_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        tip = (int)sliderTip.Value;
        lblTip.Text = $"Tip: {tip}%";
        CalculateTotal();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (sender is Button)
        {
            var btn = (Button)sender;
            var percentage = int.Parse(btn.Text.Replace("%", ""));
            sliderTip.Value = percentage;
        }
    }

    private void btnMinus_Clicked(object sender, EventArgs e)
    {
        if (noPersons > 1)
        {
            noPersons--;
        }
        lblNoPersons.Text = noPersons.ToString();
        CalculateTotal();
    }

    private void btnPlus_Clicked(object sender, EventArgs e)
    {
        noPersons++;
        lblNoPersons.Text = noPersons.ToString();
        CalculateTotal();
    }
}

