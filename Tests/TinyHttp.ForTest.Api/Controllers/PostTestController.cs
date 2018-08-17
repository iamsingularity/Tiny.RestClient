﻿using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using Tiny.Http.Models;

namespace Tiny.Http.ForTest.Api.Controllers
{
    [Route("api/PostTest")]
    [ApiController]
    public class PostTestController : ControllerBase
    {
        public PostTestController()
        {
        }

        [HttpPost("FromForm")]
        public PostResponse FromForm([FromForm] int id, [FromForm] string data)
        {
            return new PostResponse { Id = id, ResponseData = data };
        }

        [HttpPost("NoResponse")]
        public Task NoResponse([FromBody] PostRequest postRequest)
        {
            return Task.Delay(1);
        }

        [HttpPost("Complex")]
        public PostResponse Complex([FromBody] PostRequest postRequest)
        {
            return new PostResponse() { Id = postRequest.Id, ResponseData = postRequest.Data };
        }

        [HttpPost("Stream")]
        public Stream Stream([FromBody] PostRequest postRequest)
        {
            byte[] byteArray = new byte[postRequest.Id];

            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] = i % 2 == 0 ? (byte)0 : (byte)1;
            }

            Stream stream = new MemoryStream(byteArray);

            return stream;
        }
    }
}