﻿using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DataContract;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concret
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public void CreatePost(PostDto dto)
        {
            var post = new Post()
            {
                Author = dto.Author,
                Content = dto.Content.Replace("\n", "<br />"),
                Created = dto.Created,
                Id = dto.Id,
            };
            _postRepository.CreatePost(post);
        }

        public IList<PostDto> GetPosts()
        {
            var posts = _postRepository.GetPosts();
            var dtos = posts.Select(x => new PostDto()
            {
                Author = x.Author,
                Content = x.Content,
                Created = x.Created,
                Id = x.Id,
            }).ToList();

            return dtos;
        }
    }
}
