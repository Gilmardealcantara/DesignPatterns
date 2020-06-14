﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GuardiansOfTheCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // var s = PrimaryPlayer.Instance;
            // Console.WriteLine($"{s.Name} - lvl: {s.Level}");
            try
            {
                TestApiConnection().Wait();
                var board = new GameBoard();
                board.PlayArea(1).Wait();

            }
            catch (Exception e)
            {
                Console.WriteLine("Fail to initialize game");
            }
        }

        private static async Task TestApiConnection()
        {
            int maxAttempts = 20;
            int attemptInterval = 2000;
            using (var client = new HttpClient())
            {
                for (var i = 0; i < maxAttempts; ++i)
                {
                    try
                    {
                        var response = await client.GetAsync("http://localhost:5000/api/cards/health");
                        if (response.IsSuccessStatusCode)
                        {
                            return;
                        }
                    }
                    catch (Exception e) { }
                    finally
                    {
                        Console.WriteLine("Lost connection to server. Attempting to re-connect");
                        Thread.Sleep(attemptInterval);
                    }
                }
                throw new Exception("Failed to connect to server");
            }
        }
    }
}
