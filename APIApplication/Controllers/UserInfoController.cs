using Interface;
using Interface.UnitOfWork;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Transactions;
using System.Web.Http;

namespace APIApplication.Controllers
{
    public class UserInfoController : ApiController
    {
        #region IOC

        private readonly IUserInfoRepo _userInfoRepo;
        private readonly IProjectRepo _projectRepo;
        private readonly IUnitOfWork _unitOfWork;
        public  UserInfoController()
        {
        }
        public UserInfoController(IUserInfoRepo userInfoRepo, IUnitOfWork unitOfWork, IProjectRepo projectRepo)
        {
            this._userInfoRepo = userInfoRepo;
            this._projectRepo = projectRepo;
            this._unitOfWork = unitOfWork;

        }
        #endregion

        public IHttpActionResult Get(int id)
        {
            
            var aa = new Entity.UserInfo() { name = "a1", pwd = "123" };
            //不包含事物提交数据
            _unitOfWork.Commit();


            var user = _userInfoRepo.Get(i=>i.id==1);
            var data= _projectRepo.GetAll();

            //多表事务提交
            _unitOfWork.TranCommit(Test);

   

            return Ok(user);


        }
        public void Test() {

            var aa = new Entity.UserInfo() { name = "bb", pwd = "123" };
            _projectRepo.Add(new Entity.Project() {Id=1, ProjectCode = "cc", ProjectName = "1", Addres = "" });
            _userInfoRepo.Add(aa);

          
        }
    }
}
