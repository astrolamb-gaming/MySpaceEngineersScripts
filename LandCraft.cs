// Copy this function directly into your script, then call the function in your Main() method.

public void Land() {
  var lg = (IMyLandingGear) GridTerminalSystem.GetBlockWithName("Landing Gear");
  var rc = (IMyRemoteControl) GridTerminalSystem.GetBlockWithName("Remote Control);
  var sensor = (IMySensor) GridTerminalSystem.GetBlockWithName("Sensor");
  
  if (sensor == null) {
    var sensor = (IMySensor) GridTerminalSystem.GetBlockWithName("LandingSensor");
    
    
    
    
 } else {
  sensor.SetCustomName("LandingSensor");
 }
  
  
