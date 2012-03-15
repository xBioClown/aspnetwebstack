﻿namespace System.Web.Http
{
    public class ActionAttributeTestController : ApiController
    {
        [HttpGet]
        public void RetriveUsers() { }

        [HttpPost]
        public void AddUsers(int id) { }

        [HttpPut]
        public void UpdateUsers(User user) { }

        [HttpDelete]
        public void RemoveUsers(string name) { }

        [HttpOptions]
        public void Help(int id) { }

        [HttpHead]
        public void Ping(int id) { }

        [HttpPatch]
        public void Update(int id) { }

        [AcceptVerbs("PATCH", "HEAD")]
        [CLSCompliant(false)]
        public void Users(double key) { }

        [NonAction]
        public void NonAction() { }

        [NonAction]
        [AcceptVerbs("ACTION")]
        public void NonActionWitHttpMethod() { }

        public void Options() { }

        public void Head() { }

        public void PatchUsers() { }
    }
}
