using Carmenta.Engine;
using Carmenta.ResQMapAPI.Models;
using Carmenta.ResQMapAPI.Models.CarmentaEngineModels;
using Carmenta.ResQMapAPI.Plugins.CustomEntities;
using System;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorPlugin
{
    /// <summary>
    /// The Sensors panel implementation that handles all business logic regarding the data gathered from sensors,
    /// </summary>
    public class SensorPanel : CustomPanel<SensorControl>
    {
        /// <summary>
        /// The root model from the ResQMap API, received in the <see cref="OnAttached"/> method.
        /// </summary>
        private ResQMapModel resQMapModel;

        /// <summary>
        /// The memory dataset containing all MIDAS Gold Traffic Data features in the map. This dataset is filled in the
        /// <see cref="FillMidasGoldTrafficDataSet"/> method which reads the Traffic Speed and Traffic Flow from Sensors located on map
        /// which are stored in .xml file
        /// MIDAS Gold Traffic contains POINT DATA
        /// </summary>
        private MemoryDataSet MidasGoldTrafficDataSet;

        /// <summary>
        /// The memory dataset containing all Processed Traffic Data - Fused FVD and Sensor Data. This dataset is filled in the
        /// <see cref="FillFusedFvdAndSensorsDataSet"/> method which reads the travel time, free flow travel time and
        ///  normally expected travel time data from Sensors located on map which are stored in .xml file
        /// Fused FVD and Sensor Data contains LINE DATA
        /// </summary>
        private MemoryDataSet FusedFvdAndSensorsDataSet;

        /// <summary>
        /// The memory dataset containing all Events data. This dataset is filled in the <see cref="FillEventsDataSet"/> method
        /// which reads the Roadworks and Weather Events related data from Sensors located on map which are stored in .xml file
        /// Events data set contains description of event occured on particular road section
        /// </summary>
        private MemoryDataSet EventsDataSet;



        public override void OnAttached(ResQMapModel resQMapModel)
        {
            // Remember the ResQMapModel for use later on
            this.resQMapModel = resQMapModel;

            //Set up the handling of feature selection in the map
            SetupSelectionHandling();

            //add the layer in which data from MIDAS Gold Traffic sensors will be visualized
            this.MidasGoldTrafficDataSet = AddLayer();

            //add the layer in which data from Fused FVD and Sensors will be visualized
            this.FusedFvdAndSensorsDataSet = AddLayer();

            //add the layer in which data from Events sensors will be visualized
            this.EventsDataSet = AddLayer();

            FillMidasGoldTrafficDataSet(MidasGoldTrafficDataSet);
            FillFusedFvdAndSensorsDataSet(FusedFvdAndSensorsDataSet);
            FillEventsDataSet(EventsDataSet);
        }

        /// <summary>
        /// Sets up the handling of feature selection in the map. We hook up a handler for the SelectionChanged
        /// event in the Carmenta Engine MapControl.
        /// </summary>
        private void SetupSelectionHandling()
        {
            
        }

        /// <summary>
        /// Adds the CarmentaEngine layer that will be used to visualize data from All sensor sources in the map.
        /// </summary>
        /// <returns>The MemoryDataSet that is created at the end of the operator chain for this new layer.</returns>
        private MemoryDataSet AddLayer()
        {
            //get the layer set in which we should put the new layer
            LayerSet layerSet = resQMapModel.CarmentaEngine.GetLayerSet(CarmentaEngineModel.LayerSetDefinitions.AboveOverlays);

            //Create the layer and put it in the layer set
            var layer = new OrdinaryLayer { Selectable = true };
            layerSet.Layers.Add(layer);

            //Create the read operator and the data set using WGS84LongLat as reference system
            var dataSet = new MemoryDataSet(Crs.Wgs84LongLat);
            var readOperator = new ReadOperator(dataSet);

            //Create the visualization operator which will visualize lines
            var visualizationOperator = new VisualizationOperator(readOperator);


            //Set the visualization operator as the input to the layer. Now the operator chain is complete
            layer.Input = visualizationOperator;

            return dataSet;
        }

        /// <summary>
        /// Fills the provided dataset with map features from the MIDAS_Loop_Traffic_Data.xml file.
        /// </summary>
        /// <param name="MidasGoldTrafficDataSet">The dataset to fill with map features.</param>
        private void FillMidasGoldTrafficDataSet(MemoryDataSet dataSet)
        {
            //XmlReader reader = XmlReader.Create("putanja_na_disku");
            //XElement element = XElement.Load(reader);
            //reader.Close();



        }

        /// <summary>
        /// Fills the provided dataset with map features from the Fused_FVD_and_Sensor_PTD.xml file.
        /// </summary>
        /// <param name="FusedFvdAndSensorsDataSet">The dataset to fill with map features.</param>
        private void FillFusedFvdAndSensorsDataSet(MemoryDataSet dataSet)
        {
            //ovdje ide ucitavanje .xml datoteke i parsiranje
        }

        /// <summary>
        /// Fills the provided dataset with map features from the Event_Data_-_Full_Refresh.xml file.
        /// </summary>
        /// <param name="EventsDataSet">The dataset to fill with map features.</param>
        private void FillEventsDataSet(MemoryDataSet dataSet)
        {
            //ovdje ide ucitavanje .xml datoteke i parsiranje
        }
    }
}