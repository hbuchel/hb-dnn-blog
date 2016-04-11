'use strict';

angular.module('blogApp.blogFactory',[])
.factory('blogFactory', ['$http', function ($http) {

  var moduleId = 417;
  // DNN Services Framework
  var $self = this;
  if ($.ServicesFramework) {
    var _sf = $.ServicesFramework(moduleId);
    $self.ServiceRoot = _sf.getServiceRoot('Blog');
    $self.ServicePath = $self.ServiceRoot + "Item";
    $self.Headers = {
      "ModuleId": moduleId,
      "TabId": _sf.getTabId(),
      "RequestVerificationToken": _sf.getAntiForgeryValue()
    };
  }

  var blogFactory = {};

  blogFactory.getPosts = function () {
    return $http.get($self.ServicePath, {
      headers: $self.Headers
    });
  };

  blogFactory.getPost = function (id) {
    return $http.get($self.ServicePath + '/' + id);
  };

  //blogFactory.insertCustomer = function (cust) {
  //  return $http.post(urlBase, cust);
  //};

  //blogFactory.updateCustomer = function (cust) {
  //  return $http.put(urlBase + '/' + cust.ID, cust)
  //};

  //blogFactory.deleteCustomer = function (id) {
  //  return $http.delete(urlBase + '/' + id);
  //};

  //blogFactory.getOrders = function (id) {
  //  return $http.get(urlBase + '/' + id + '/orders');
  //};

  return blogFactory;
}]);
