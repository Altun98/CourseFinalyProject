using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Concrete;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.DataAccess.Concrete.EntityFramework;
using CourseFinalyProject.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.DependncyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            #region ManagertoService
            builder.RegisterType<AcademicDegreeManager>().As<IAcademicDegreeService>().SingleInstance();
            builder.RegisterType<AttestationManager>().As<IAttestationService>().SingleInstance();
            builder.RegisterType<BloodTypeManager>().As<IBloodTypeService>().SingleInstance();
            builder.RegisterType<CombatOperationsManager>().As<ICombatOperationsService>().SingleInstance();
            builder.RegisterType<ConscriptioManager>().As<IConscriptioService>().SingleInstance();
            builder.RegisterType<DepartamentManager>().As<IDepartamentService>().SingleInstance();
            builder.RegisterType<DiscountedServiceManager>().As<IDiscountedServiceService>().SingleInstance();
            builder.RegisterType<DocumentTypeManager>().As<IDocumentTypeService>().SingleInstance();
            builder.RegisterType<DodtGoAbroadManager>().As<IDodtGoAbroadService>().SingleInstance();
            builder.RegisterType<EducationManager>().As<IEducationService>().SingleInstance();
            builder.RegisterType<ExtenstionOFServiceLifeManager>().As<IExtenstionOFServiceLifeService>().SingleInstance();
            builder.RegisterType<EmployeeDocumentManager>().As<IEmployeeDocumentService>().SingleInstance();
            builder.RegisterType<EmployeeInfoManager>().As<IEmployeeInfoService>().SingleInstance();
            builder.RegisterType<EmployeeManager>().As<IEmployeeService>().SingleInstance();
            builder.RegisterType<FrutherEducationManager>().As<IFrutherEducationService>().SingleInstance();
            builder.RegisterType<GiveManager>().As<IGiveService>().SingleInstance();
            builder.RegisterType<LaborActivityManager>().As<ILaborActivityService>().SingleInstance();
            builder.RegisterType<MilitaryServiceManager>().As<IMilitaryServiceService>().SingleInstance();
            builder.RegisterType<MilitaryRankManager>().As<IMilitaryRankService>().SingleInstance();
            builder.RegisterType<BranchManager>().As<IBranchService>().SingleInstance();
            builder.RegisterType<RelativeTypeManager>().As<IRelativeTypeService>().SingleInstance();
            builder.RegisterType<EmployeeFamilyMemberManager>().As<IEmployeeFamilyMemberService>().SingleInstance();
            builder.RegisterType<HonoraryTitleManager>().As<IHonoraryTitleService>().SingleInstance();
            builder.RegisterType<MedalTypeManager>().As<IMedalTypeService>().SingleInstance();
            builder.RegisterType<MHHKTypeManager>().As<IMHHKTypeService>().SingleInstance();
            builder.RegisterType<MHHKManager>().As<IMHHKService>().SingleInstance();
            builder.RegisterType<AwardsTypeManager>().As<IAwardsTypeService>().SingleInstance();
            builder.RegisterType<AwardsManager>().As<IAwardsService>().SingleInstance();
            builder.RegisterType<LanguageManager>().As<ILanguageService>().SingleInstance();
            builder.RegisterType<ForignLanguageManager>().As<IForignLanguageService>().SingleInstance();



            #endregion
            #region EfDaltoIDal
            builder.RegisterType<EfAcademicDegreeDal>().As<IAcademicDegreeDal>().SingleInstance();
            builder.RegisterType<EfAttestationDal>().As<IAttestationDal>().SingleInstance();
            builder.RegisterType<EfBloodTypeDal>().As<IBloodTypeDal>().SingleInstance();
            builder.RegisterType<EfCombatOperationsDal>().As<ICombatOperationsDal>().SingleInstance();
            builder.RegisterType<EfConscriptionDal>().As<IConscriptioDal>().SingleInstance();
            builder.RegisterType<EfDepartamentDal>().As<IDepartamentDal>().SingleInstance();
            builder.RegisterType<EfDiscountedServiceDal>().As<IDiscountedServiceDal>().SingleInstance();
            builder.RegisterType<EfDocumentTypeDal>().As<IDocumentTypeDal>().SingleInstance();
            builder.RegisterType<EfDodtGoAbroadDal>().As<IDodtGoAbroadDal>().SingleInstance();
            builder.RegisterType<EfEducationDal>().As<IEducationDal>().SingleInstance();
            builder.RegisterType<EfExtenstionOFServiceLifeDal>().As<IExtenstionOFServiceLifeDal>().SingleInstance();
            builder.RegisterType<EfEmployeeDocumentDal>().As<IEmployeeDocumentDal>().SingleInstance();
            builder.RegisterType<EfEmployeeInfoDal>().As<IEmployeeInfoDal>().SingleInstance();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>().SingleInstance();
            builder.RegisterType<EfFrutherEducationDal>().As<IFrutherEducationDal>().SingleInstance();
            builder.RegisterType<EfGiveDal>().As<IGiveDal>().SingleInstance();
            builder.RegisterType<EfLaborActivityDal>().As<ILaborActivityDal>().SingleInstance();
            builder.RegisterType<EfMilitaryServiceDal>().As<IMilitaryServiceDal>().SingleInstance();
            builder.RegisterType<EfMilitaryRankDal>().As<IMilitaryRankDal>().SingleInstance();
            builder.RegisterType<EfBranchDal>().As<IBranchDal>().SingleInstance();
            builder.RegisterType<EfRelativeTypeDal>().As<IRelativeTypeDal>().SingleInstance();
            builder.RegisterType<EfEmployeeFamilyMemberDal>().As<IEmployeeFamilyMemberDal>().SingleInstance();
            builder.RegisterType<EfHonoraryTitleDal>().As<IHonoraryTitleDal>().SingleInstance();
            builder.RegisterType<EfMedalTypeDal>().As<IMedalTypeDal>().SingleInstance();
            builder.RegisterType<EfMHHKTypeDal>().As<IMHHKTypeDal>().SingleInstance();
            builder.RegisterType<EfMHHKDal>().As<IMHHKDal>().SingleInstance();
            builder.RegisterType<EfAwardsTypeDal>().As<IAwardsTypeDal>().SingleInstance();
            builder.RegisterType<EfAwardsDal>().As<IAwardsDal>().SingleInstance();
            builder.RegisterType<EfLanguageDal>().As<ILanguageDal>().SingleInstance();
            builder.RegisterType<EfForignLanguageDal>().As<IForignLanguageDal>().SingleInstance();

            #endregion


            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
