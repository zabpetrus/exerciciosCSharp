using AutoMapper;
using ConectarAPI.Application.ViewModel;
using ConectarAPI.Model.Entity;

namespace ConectarAPI.Tests.Application
{
    public class ClienteViewModelTests
    {

        private IMapper _mapper;

        public ClienteViewModelTests()
        {
            var config = new MapperConfiguration(cfg =>
                  cfg.CreateMap<Cliente, ClienteViewModel>()
             );

            _mapper = config.CreateMapper();
        }


        [Fact]
        public void Test1()
        {
            Cliente cliente = new Cliente();
            cliente.Id = 1;
            cliente.Nome = "Joana";
            cliente.DataNascimento = DateTime.Parse("12/01/2001");
            
            var createViewModel = _mapper.Map<ClienteViewModel>(cliente);

            Assert.NotNull(createViewModel);
            Assert.Equal(cliente.Nome, createViewModel.Nome);


        }
    }
}
