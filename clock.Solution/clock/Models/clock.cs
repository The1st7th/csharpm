using System.Collections.Generic;
using System;

namespace clocks.Models
{
  public class clock
  {
  private int _hour;
  private int _minute;
  private int _angle;

  public void setHour(string hour){
    _hour = int.Parse(hour);
  }
  public void setMinute(string minute){
    _minute = int.Parse(minute);
  }
  public int getHour(){
    return _hour;
  }
  public int getMinute(){
    return _minute;
  }
  public int angle(){
    _angle = (_hour * 30) - (_minute * 6);
    return _angle;
  }
  }
}
