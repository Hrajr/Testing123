using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml.Linq;
using Xunit;
using TestingProject;

namespace SecUnitTest
{
    public class UnitTest1
    {
        public ZapController zapController = new ZapController();

        [Fact]
        public async Task TargetHeartbeatTest()
        {
            // Act

            // Arrange

            // Assert
            Assert.True(await zapController.UrlIsReachable());
        }

        [Fact]
        public void StartSecurityTest()
        {
            // Act

            // Arrange

            // Assert
            Assert.True(zapController.StartZapScan());
        }

        [Fact]
        public void GenerateResultsTest()
        {
            // Act
            zapController.StartZapScan();

            // Arrange
            List<XElement> RiskList = zapController.SortResultXML();

            // Assert
            Assert.NotNull(RiskList);
        }

        [Fact]
        public void StartAdvancedScan()
        {
            // Act
            zapController.StartScan();

            // Arrange
            var result = zapController.GenerateResultHTML();

            // Assert
            Assert.NotEmpty(result);
        }

        [Fact]
        public void HighVulnerabilityTest()
        {
            zapController.StartScan();
        }

        [Fact]
        public void ResultLogginTest()
        {

        }
    }
}
