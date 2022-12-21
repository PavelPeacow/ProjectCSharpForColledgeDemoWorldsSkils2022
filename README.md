# ProjectCSharpForColledgeDemoWorldsSkils2022

<h6>  Проект для подготовки к демо экзамену worldSkills в колледже


# Timer
``` c#
DispatcherTimer dispatcherTimer;
TimeSpan time;
  
private void createTimer()
{
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
