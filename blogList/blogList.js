'use strict';

angular.module('blogApp.blogList', ['ngRoute'])

.config(['$routeProvider', function ($routeProvider) {
  $routeProvider.when('/', {
    templateUrl: '/DesktopModules/Blog/blogList/blogList.html',
    controller: 'BlogListCtrl'
  });
}])

.controller('BlogListCtrl', ['$scope', 'blogFactory', function ($scope, blogFactory) {
  
  getPosts();

  function getPosts() {
    blogFactory.getPosts()
        .then(function (response) {
          $scope.posts = response.data;
        }, function (error) {
          console.log('error getting posts');
        });
  }

  $scope.getUrl = function (path) {
    return $location.path().replace(/\/industry.*/i, '') + '/' + path;
  };
}]);