# ProjectCSharpForColledgeDemoWorldsSkils2022

<h6>  Проект для подготовки к демо экзамену worldSkills в колледже


# Timer
``` c#
DispatcherTimer dispatcherTimer;
TimeSpan time;
  
private void createTimer()
{
    time = TimeSpan.FromMinutes(25);
    dispatcherTimer = new DispatcherTimer();
    dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
    dispatcherTimer.Tick += DispatcherTimer_Tick;
    dispatcherTimer.Start();
}

private void DispatcherTimer_Tick(object sender, EventArgs e)
{
    if (time == TimeSpan.Zero) dispatcherTimer.Stop();
    else
    {
        time = time.Add(TimeSpan.FromSeconds(-1));
        Timer.Text = time.ToString("c");
    }
}
```
  
# Datetime
``` c#
public string getFormattedDate
    {
        get
        {
            if (staff_date == null) return "";
            return ((DateTime)staff_date).ToString("M");
        }
    }
```
