'use strict';

angular.module('blogApp.blogPost', ['ngRoute'])

.config(['$routeProvider', function ($routeProvider) {
  $routeProvider.when('/post/:id', {
    templateUrl: '/DesktopModules/Blog/blogPost/blogPost.html',
    controller: 'BlogPostCtrl'
  });
}])

.controller('BlogPostCtrl', [function ($scope, blogFactory, $routeParams) {

  
  $scope.postId = $routeParams.id;
  
  function getPost() {
    blogFactory.getPost()
        .then(function (response) {
          $scope.post = response.data;
        }, function (error) {
          console.log('error getting posts');
        });
  }
}]);