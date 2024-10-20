using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenMeteo;
using System;
using System.Threading.Tasks;

namespace OpenMeteoTests;

[TestClass]
public class MetadataTests
{
    [DataTestMethod]
    [DataRow(WeatherModelOptionsParameter.ecmwf_ifs025)]
    [DataRow(WeatherModelOptionsParameter.ecmwf_aifs025)]
    [DataRow(WeatherModelOptionsParameter.icon_global)]
    [DataRow(WeatherModelOptionsParameter.icon_eu)]
    [DataRow(WeatherModelOptionsParameter.icon_d2)]
    [DataRow(WeatherModelOptionsParameter.meteofrance_arpege_world)]
    [DataRow(WeatherModelOptionsParameter.meteofrance_arpege_europe)]
    [DataRow(WeatherModelOptionsParameter.meteofrance_arome_france)]
    [DataRow(WeatherModelOptionsParameter.ukmo_uk_deterministic_2km)]
    [DataRow(WeatherModelOptionsParameter.ukmo_global_deterministic_10km)]
    [DataRow(WeatherModelOptionsParameter.gfs_global)]
    [DataRow(WeatherModelOptionsParameter.gfs_graphcast025)]
    [DataRow(WeatherModelOptionsParameter.gfs_hrrr)]
    [DataRow(WeatherModelOptionsParameter.ncep_nbm_conus)]
    [DataRow(WeatherModelOptionsParameter.gem_global)]
    [DataRow(WeatherModelOptionsParameter.gem_hrdps_continental)]
    [DataRow(WeatherModelOptionsParameter.gem_regional)]
    [DataRow(WeatherModelOptionsParameter.jma_gsm)]
    public async Task Metadata_Async_Test(WeatherModelOptionsParameter model)
    {
        var historicalDateTime = DateTime.UtcNow.AddDays(-2);
        OpenMeteoClient client = new();
        var res = await client.QueryWeatherForecastMetadata(model);

        Assert.IsNotNull(res);
        Assert.IsTrue(res.DataEndTime > historicalDateTime);
        Assert.IsTrue(res.LastRunInitialisationTime > historicalDateTime);
        Assert.IsTrue(res.LastRunAvailabilityTime > historicalDateTime);
        Assert.IsTrue(res.LastRunModificationTime > historicalDateTime);
        Assert.IsTrue(res.UpdateIntervalSeconds > 0);
        Assert.IsTrue(res.TemporalResolutionSeconds > 0);

    }
}
