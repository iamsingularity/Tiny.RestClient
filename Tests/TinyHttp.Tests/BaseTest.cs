﻿namespace Tiny.Http.Tests
{
    public class BaseTest
    {
        private object _toLock = new object();
        private TinyHttpClient _httpClient;

        protected TinyHttpClient GetClient()
        {
            lock (_toLock)
            {
                if (_httpClient == null)
                {
                    _httpClient = new TinyHttpClient(new System.Net.Http.HttpClient(), "http://localhost:53095/api/");
                }
            }

            return _httpClient;
        }

        protected TinyHttpClient GetClientWithXMLSerialization()
        {
            lock (_toLock)
            {
                if (_httpClient == null)
                {
                    _httpClient = new TinyHttpClient(new System.Net.Http.HttpClient(), "http://localhost:53095/api/", new TinyXmlSerializer(), new TinyXmlDeserializer());
                }
            }

            return _httpClient;
        }
    }
}