﻿using JwtBearerPOC.Config;
using JwtBearerPOC.Model;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace JwtBearerPOC.Services.TokenServ;

public class TokenService
{
    public string Generate(User user) 
    {
        //Cria uma instância do JwtSecurityTokenHandler
        var handler = new JwtSecurityTokenHandler();



        //Convertendo chave do usuário para um array de bytes
        var key = Encoding.ASCII.GetBytes(Configuration.PrivateKey);

        //Criando uma signin credentials
        var creadentials = new SigningCredentials(
                new SymmetricSecurityKey(key), //Precisa ser passado em formado de Symmetric Key 
                SecurityAlgorithms.HmacSha256Signature); //Utilizando constante do .net para determinar o tipo de encriptação



        //Criando o token descriptor para pegar o conteúdo
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            SigningCredentials = creadentials,
            Expires = DateTime.UtcNow.AddMinutes(10) //Expira em 10 minutos
        };



        //Gera um token
        var token = handler.CreateToken(tokenDescriptor);


        //Gera uma string do Token
        return handler.WriteToken(token);
    }
}
