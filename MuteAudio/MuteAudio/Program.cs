using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;

namespace MuteAudio
{
    class Program
    {

        

        static void Main(string[] args)
        {
            int MUTE_DURATION_SECONDS = 26;

            try
            {

                foreach(var arg in args)
                {
                    if(arg.StartsWith("/MUTE_DURATION_SECONDS="))
                    {
                        int.TryParse(arg.Replace("/MUTE_DURATION_SECONDS=", ""), out MUTE_DURATION_SECONDS);
                    }
                }

                //Instantiate an Enumerator to find audio devices
                NAudio.CoreAudioApi.MMDeviceEnumerator MMDE = new NAudio.CoreAudioApi.MMDeviceEnumerator();
                //Get all the devices, no matter what condition or status
                NAudio.CoreAudioApi.MMDeviceCollection DevCol = MMDE.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.All);
                //Loop through all devices
                foreach (NAudio.CoreAudioApi.MMDevice dev in DevCol)
                {
                    try
                    {
                        if (dev.State == NAudio.CoreAudioApi.DeviceState.Active && dev.FriendlyName.StartsWith("Headphones"))
                        {
                            //var newVolume = (float)Math.Max(Math.Min(level, 100), 0) / (float)100;

                            //Set at maximum volume
                            //  dev.AudioEndpointVolume.MasterVolumeLevelScalar = newVolume;

                            //   dev.AudioEndpointVolume.Mute = level == 0;
                            //Console.WriteLine("Volume of " + dev.FriendlyName + " is " + );
                            dev.AudioEndpointVolume.Mute = true;

                            for (var x = MUTE_DURATION_SECONDS; x > 0; x--)
                            {
                                Console.Clear();
                                Console.WriteLine("Audio Muted.  Time Remaining: " + x.ToString());
                                Thread.Sleep(1000);
                            }

                            dev.AudioEndpointVolume.Mute = false;

                            //Get its audio volume
                            //  Console.WriteLine("Volume of " + dev.FriendlyName + " is " + dev.AudioEndpointVolume.MasterVolumeLevelScalar.ToString());
                        }
                        else
                        {
                            // Console.WriteLine("Ignoring device " + dev.FriendlyName + " with state " + dev.State);
                        }
                    }
                    catch (Exception ex)
                    {
                        //Do something with exception when an audio endpoint could not be muted
                        Console.WriteLine(dev.FriendlyName + " could not be muted with error " + ex);
                    }
                }
            }
            catch (Exception ex)
            {
                //When something happend that prevent us to iterate through the devices
                Console.WriteLine("Could not enumerate devices due to an excepion: " + ex.Message);
            }


        }


    }
}
