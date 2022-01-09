using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AuthorBlazor.Model;

namespace AuthorBlazor.Data
{
    public class AuthorServices
    {
        
        private readonly HttpClient client;
        private string uri = "https://localhost:5003";

        public AuthorServices()
        {
            client = new HttpClient();
        }

        public async Task<Author> PostAuthor(Author author)
        {
            var authorAsJson = JsonSerializer.Serialize(author);
            var content = new StringContent(authorAsJson, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{uri}/Authors", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception();
            }

            var authorAsJsonResponse = await response.Content.ReadAsStringAsync();
            var newAuthor = JsonSerializer.Deserialize<Author>(authorAsJsonResponse);
            return newAuthor;
        }

        public async Task<List<Author>> GetAllAuthors()
        {
            var responseMessage =
                await client.GetAsync($"{uri}/AllAuthors");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
            var result = await responseMessage.Content.ReadAsStringAsync();
            var authors = JsonSerializer.Deserialize<List<Author>>(result);
            return authors;
        }

        public async Task<Book> PostBook(int authorId, Book book)
        {
            var bookAsJson = JsonSerializer.Serialize(book);
            var content = new StringContent(bookAsJson, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{uri}/Books/{authorId}", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception();
            }

            var bookAsJsonResponse = await response.Content.ReadAsStringAsync();
            var newBook = JsonSerializer.Deserialize<Book>(bookAsJsonResponse);
            return newBook;
            
        }

        public async Task RemoveBook(int bookId)
        {
            HttpResponseMessage response = await client.DeleteAsync($"{uri}/Books/{bookId}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
        }
    }
}