using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Communication.Requests;
using RocketseatAuction.API.Filters;
using RocketseatAuction.API.UseCases.Offers.CreateOffer;

namespace RocketseatAuction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttibute))]
public class OfferController : RocketseatAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer(
        [FromRoute] int itemId,
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId, request);

        return Created(string.Empty, id);
    }
}


// Uma oferta está associada a um item
// Como eu preciso passar o Id de um Iem? Como eu vejo o Id de um Produto? - Quando recuperar os leilões que contém os Ids dos Produtos
// Precisa enviar o endpoint o Id do produto que desejar criar uma oferta para ele, passando o Id pela URL(Route)
// Este endpoint precisa receber o objeto RequestCreateOfferJson