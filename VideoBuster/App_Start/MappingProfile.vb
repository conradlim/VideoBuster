Imports AutoMapper
Imports VideoBuster.Dtos
Imports VideoBuster.Models


Namespace App_Start
    Public Class MappingProfile
        Inherits Profile

        Public Sub MappingProfile()
            Mapper.CreateMap(Of Customer, CustomerDto)().ForMember(Function(dest) dest.id, Sub(opt) opt.MapFrom(Function(src) src.id)) _
                .ForMember(Function(dest) dest.Name, Sub(opt) opt.MapFrom(Function(src) src.Name)) _
                .ForMember(Function(dest) dest.isSubscribedToNewsletter, Sub(opt) opt.MapFrom(Function(src) src.isSubscribedToNewsletter)) _
                .ForMember(Function(dest) dest.MembershipTypeid, Sub(opt) opt.MapFrom(Function(src) src.MembershipTypeid)) _
                .ForMember(Function(dest) dest.Birthdate, Sub(opt) opt.MapFrom(Function(src) src.Birthdate))

            Mapper.CreateMap(Of CustomerDto, Customer)().ForMember(Function(dest) dest.id, Sub(opt) opt.MapFrom(Function(src) src.id))
        End Sub


    End Class

End Namespace
