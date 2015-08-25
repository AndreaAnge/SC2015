using Carmenta.ResQMapAPI.Plugins.CustomEntities.CustomEntityDefinitions;
using Carmenta.ResQMapAPI.Plugins.Registrars;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorPlugin
{
    public class Plugin : Carmenta.ResQMapAPI.Plugins.Plugin
    {
        protected override void RegisterCustomPanels(CustomPanelRegistrar registrar)
        {
            //registrar.Register(
            //    "Sensors",
            //    typeof(SensorPanel),
            //    CustomPanelOrientation.Left
            //    //Resource1.slika
            //    );

            base.RegisterCustomPanels(registrar);
        }
    }
}