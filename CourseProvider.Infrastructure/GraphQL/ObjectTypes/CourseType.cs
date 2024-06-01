using CourseProvider.Infrastructure.Data.Entities;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace CourseProvider.Infrastructure.GraphQL.ObjectTypes;

public class CourseType : ObjectType<CourseEntity>
{
    protected override void Configure(IObjectTypeDescriptor<CourseEntity> descriptor)
    {
        descriptor.Field(c => c.Id).Type<NonNullType<IdType>>();
        descriptor.Field(c => c.ImageUri).Type<StringType>();
        descriptor.Field(c => c.ImageHeaderUri).Type<StringType>();
        descriptor.Field(c => c.IsBestseller).Type<BooleanType>();
        descriptor.Field(c => c.IsDigital).Type<BooleanType>();
        descriptor.Field(c => c.Title).Type<NonNullType<StringType>>();
        descriptor.Field(c => c.Ingress).Type<StringType>();
        descriptor.Field(c => c.StarRating).Type<NonNullType<FloatType>>();
        descriptor.Field(c => c.Reviews).Type<StringType>();
        descriptor.Field(c => c.Hours).Type<StringType>();
        descriptor.Field(c => c.LikesInProcent).Type<StringType>();
        descriptor.Field(c => c.LikesInNumbers).Type<StringType>();
        descriptor.Field(c => c.Categories).Type<ListType<StringType>>();
        descriptor.Field(c => c.Authors).Type<ListType<AuthorType>>();
        descriptor.Field(c => c.Prices).Type<PriceType>();
        descriptor.Field(c => c.Content).Type<ContentType>();



    }

}
public class AuthorType : ObjectType<AuthorEntity>
{
    protected override void Configure(IObjectTypeDescriptor<AuthorEntity> descriptor)
    {
        descriptor.Field(a => a.Name).Type<StringType>();
    }
}
public class PriceType : ObjectType<PriceEntity>
{
    protected override void Configure(IObjectTypeDescriptor<PriceEntity> descriptor)
    {
        descriptor.Field(p => p.Currency).Type<StringType>();
        descriptor.Field(p => p.Price).Type<DecimalType>();
        descriptor.Field(p => p.Discount).Type<DecimalType>();
    }
}
public class ContentType : ObjectType<ContentEntity>
{
    protected override void Configure(IObjectTypeDescriptor<ContentEntity> descriptor)
    {
        descriptor.Field(c => c.Description).Type<StringType>();
        descriptor.Field(c => c.Includes).Type<ListType<StringType>>();
        descriptor.Field(c => c.ProgramDetails).Type<ListType<ProgramDetailItemType>>();
    }
}
public class ProgramDetailItemType : ObjectType<ProgramDetailItemEntity>
{
    protected override void Configure(IObjectTypeDescriptor<ProgramDetailItemEntity> descriptor)
    {
        descriptor.Field(pd => pd.Id).Type<NonNullType<IntType>>();
        descriptor.Field(pd => pd.Title).Type<StringType>();
        descriptor.Field(pd => pd.Description).Type<StringType>();
    }
}
