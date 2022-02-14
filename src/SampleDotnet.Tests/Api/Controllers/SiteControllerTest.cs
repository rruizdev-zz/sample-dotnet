using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SampleDotnet.Api.Controllers;
using SampleDotnet.Application.Query.Site.GetAll;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SampleDotnet.Tests.Api.Controllers
{
    public class SiteControllerTest
    {
        private readonly Mock<IMediator> _mediatorMock;

        private readonly SiteController _sut;

        public SiteControllerTest()
        {
            _mediatorMock = new Mock<IMediator>();

            _sut = new SiteController(_mediatorMock.Object);
        }

        [Fact]
        public async Task GetAll_Success()
        {
            _mediatorMock.Setup(x => x.Send(It.IsAny<GetAllSitesRequest>(), CancellationToken.None))
                .ReturnsAsync(new GetAllSitesResponse());

            var _ = await _sut.GetAll();

            Assert.IsAssignableFrom<OkObjectResult>(_);
            Assert.IsAssignableFrom<GetAllSitesResponse>(((OkObjectResult)_).Value);
            _mediatorMock.Verify(x => x.Send(It.IsAny<GetAllSitesRequest>(), CancellationToken.None), Times.Once);
        }
    }
}
