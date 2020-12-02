using AutoMapper;
using TeduShop.Models.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<Error, ErrorViewModel>();
            Mapper.CreateMap<Footer, FooterViewModel>();
            Mapper.CreateMap<MenuGroup, MenuGroupViewModel>();
            Mapper.CreateMap<Menu, MenuViewModel>();
            Mapper.CreateMap<OrderDetail, OrderDetailViewModel>();
            Mapper.CreateMap<Order, OrderViewModel>();
            Mapper.CreateMap<Page, PageViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<PostTag, PostTagViewModel>();
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<ProductCategory, ProductCategoryViewModel>();
            Mapper.CreateMap<ProductTag, ProductTagViewModel>();
            Mapper.CreateMap<Product, ProductViewModel>();
            Mapper.CreateMap<Slide, SlideViewModel>();
            Mapper.CreateMap<SupportOnline, SupportOnlineViewModel>();
            Mapper.CreateMap<SystemConflig, SystemConfligViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
            Mapper.CreateMap<VisitorStatistic, VisitorStatisticViewModel>();

        }
    }
}