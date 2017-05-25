// Copy this function directly into your script, then call the function in your Main() method.

// WIP

public void Land() {
  var lg = (IMyLandingGear) GridTerminalSystem.GetBlockWithName("Landing Gear");
  var rc = (IMyRemoteControl) GridTerminalSystem.GetBlockWithName("Remote Control);
  var sensor = (IMySensorBlock) GridTerminalSystem.GetBlockWithName("Sensor");
  
  if (sensor == null) {
    var sensor = (IMySensorBlock) GridTerminalSystem.GetBlockWithName("LandingSensor");
    if (sensor == null) {
      return;
    }
    
    
    
    
 } else {
    // Happens first time program is run on the craft.
    sensor.SetCustomName("LandingSensor");
 }
  
  
