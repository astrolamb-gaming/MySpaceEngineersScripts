// Copy this function directly into your script, then call the function in your Main() method.

// WIP

public void Land() {
  var lg = (IMyLandingGear) GridTerminalSystem.GetBlockWithName("Landing Gear");
  var rc = (IMyRemoteControl) GridTerminalSystem.GetBlockWithName("Remote Control);
  var sensor = (IMySensor) GridTerminalSystem.GetBlockWithName("Sensor");
  
  if (sensor == null) {
    var sensor = (IMySensor) GridTerminalSystem.GetBlockWithName("LandingSensor");
    if (sensor == null) {
      return;
    }
    
    
    
    
 } else {
    sensor.SetCustomName("LandingSensor");
 }
  
  
