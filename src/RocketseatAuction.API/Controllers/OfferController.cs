using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Communication.Requests;

namespace RocketseatAuction.API.Controllers;

public class OfferController : RocketseatAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute] int itemId, [FromBody] RequestCreateOfferJson request)
    {
        return Created();
    }
}


// Uma oferta está associada a um item
// Como eu preciso passar o Id de um Iem? Como eu vejo o Id de um Produto? - Quando recuperar os leilões que contém os Ids dos Produtos
// Precisa enviar o endpoint o Id do produto que desejar criar uma oferta para ele, passando o Id pela URL(Route)
// Este endpoint precisa receber o objeto RequestCreateOfferJson