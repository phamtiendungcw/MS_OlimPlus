﻿using MediatR;

namespace OlimPlus.Application.Features.Category.Commands.CreateCategoryCommand
{
    public class CreateCategoryCommand : IRequest<int>
    {
        public string CategoryName { get; set; }
        public int ParentCategoryId { get; set; }
        public Domain.Entity.Category? ParentCategory { get; set; }
    }
}