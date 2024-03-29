﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// User console interface with choices.
    /// </summary>
    class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        public void DisplayMenu()
        {
            Console.WriteLine("User's News Feed");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Post message");
            Console.WriteLine("2. Post image");
            Console.WriteLine("3. Display All posts");
            Console.WriteLine("4. Remove Post");
            Console.WriteLine("5. Display by Author");
            Console.WriteLine("6. Display by Date");
            Console.WriteLine("7. Add Comment");
            Console.WriteLine("8. Like post");
            Console.WriteLine("9. Quit");
            Console.Write("Type your choice number: ");
            String choice = Console.ReadLine();

            if (choice == "1")
            {
                PostMessage();
            }
            else if (choice == "2")
            {
                PostImage();
            }
            else if (choice == "3")
            {
                DisplayAll();
            }
            else if (choice == "4")
            {
                RemovePost();
            }
            else if (choice == "5")
            {
                DisplayByAuthor();
            }
            else if (choice == "6")
            {
                DisplayByTime();
            }
            else if (choice == "7")
            {
                AddComment();
            }
            else if (choice == "8")
            {
                LikePost();
            }
            else if (choice == "9")
            {
                Console.WriteLine("Thank you for using our social network");
            }
            else
            {
                Console.WriteLine("No choice with this value exist.");
                DisplayMenu();
            }

        }

        /// <summary>
        /// Displays all posts
        /// </summary>
        private void DisplayAll()
        {
            Console.WriteLine("Displaying all posts...");
            news.Display();
            DisplayMenu();
        }

        /// <summary>
        /// Adds image post
        /// </summary>
        private void PostImage()
        {
            Console.WriteLine("Posting an Image...");

            Console.Write("Type your username: ");
            string author = Console.ReadLine();

            Console.Write("Please enter your image filename: ");
            string filename = Console.ReadLine();

            Console.Write("Please enter your image caption: ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            Console.WriteLine("You have succesfully posted a photo.");
            post.Display();

            DisplayMenu();
        }

        /// <summary>
        /// Adds message post.
        /// </summary>
        private void PostMessage()
        {
            Console.WriteLine("Posting a message...");

            Console.Write("Type your username: ");
            string author = Console.ReadLine();

            Console.Write("Please enter your message: ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            Console.WriteLine("You have succesfully posted a message.");
            post.Display();

            DisplayMenu();
        }

        /// <summary>
        /// Removes post.
        /// </summary>
        private void RemovePost()
        {
            Console.WriteLine("Removing a post...");
            Console.Write("Please enter your post id: ");
            string value = Console.ReadLine();
            int id = Convert.ToInt32(value);

            news.RemovePost(id);
            DisplayMenu();
        }

        /// <summary>
        /// Displays 1 author's posts
        /// </summary>
        private void DisplayByAuthor()
        {
            Console.WriteLine("Displaying authors posts...");
            Console.Write("Please enter authors username: ");
            string username = Console.ReadLine();

            news.DisplayAuthor(username);
            DisplayMenu();
        }

        /// <summary>
        /// Displays all posts for particular time
        /// </summary>
        private void DisplayByTime()
        {
            Console.WriteLine("Displaying posts by time...");
            Console.Write("Please enter time elapsed (in seconds) for a post: ");
            string value = Console.ReadLine();
            int time = Convert.ToInt32(value);

            news.DisplayByTime(time);
            DisplayMenu();
        }

        /// <summary>
        /// Adds a comment to post
        /// </summary>
        private void AddComment()
        {
            Console.WriteLine("Adding a comment...");
            Console.Write("Please enter post id: ");
            string value = Console.ReadLine();
            int id = Convert.ToInt32(value);

            news.AddComment(id);
            DisplayMenu();
        }

        /// <summary>
        /// Adds a like to a post.
        /// </summary>
        private void LikePost()
        {
            Console.Write("Please enter post id: ");
            string value = Console.ReadLine();
            int id = Convert.ToInt32(value);

            news.LikePost(id);
            DisplayMenu();
        }
    }
}