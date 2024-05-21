using AppAlmoxarifado.Application;
using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Interfaces;
using AppAlmoxarifado.Domain.Interfaces.Application;
using AppAlmoxarifado.Domain.Interfaces.Services;
using Moq;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using AppAlmoxarifado.Infra.Repository.Context;

namespace AppAlmoxarifado.Tests.Application
{
    public class MaterialApplicationTests
    {
        private readonly Mock<IUnitOfWork<AlmoxarifadoContext>> _unitOfWorkMock;
        private readonly Mock<IMaterialService<AlmoxarifadoContext>> _materialServiceMock;
        private readonly MaterialApplication<AlmoxarifadoContext> _materialApplication;

        public MaterialApplicationTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork<AlmoxarifadoContext>>();
            _materialServiceMock = new Mock<IMaterialService<AlmoxarifadoContext>>();
            _materialApplication = new MaterialApplication<AlmoxarifadoContext>(_unitOfWorkMock.Object, _materialServiceMock.Object);
        }

        [Fact(DisplayName = "SaveAsync deve salvar material e realizar commit")]
        public async Task SaveAsync_DeveSalvarMaterialERealizarCommit()
        {
            // Arrange
            var material = new Material("Material Teste", "12345") { Id = 1 };
            _materialServiceMock.Setup(s => s.SaveAsync(material)).ReturnsAsync(material);

            // Act
            var result = await _materialApplication.SaveAsync(material);

            // Assert
            _materialServiceMock.Verify(s => s.SaveAsync(material), Times.Once);
            _unitOfWorkMock.Verify(u => u.Commit(), Times.Once);
            result.Should().Be(material);
        }

        [Fact(DisplayName = "UpdateAsync deve atualizar material e realizar commit")]
        public async Task UpdateAsync_DeveAtualizarMaterialERealizarCommit()
        {
            // Arrange
            var material = new Material("Material Atualizado", "12345") { Id = 1 };
            _materialServiceMock.Setup(s => s.UpdateAsync(material)).ReturnsAsync(material);

            // Act
            var result = await _materialApplication.UpdateAsync(material);

            // Assert
            _materialServiceMock.Verify(s => s.UpdateAsync(material), Times.Once);
            _unitOfWorkMock.Verify(u => u.Commit(), Times.Once);
            result.Should().Be(material);
        }
    }
}
