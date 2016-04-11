'use strict';

// Declare app level module which depends on views, and components
angular.module('blogApp', [
  'ngRoute',
  'blogApp.blogFactory',
  'blogApp.blogList'
]).
config(['$routeProvider','$locationProvider','$compileProvider', function ($routeProvider, $locationProvider,$compileProvider) {
  $locationProvider.html5Mode({
    enabled: true,
    requireBase: false
  });
  $routeProvider.otherwise({ redirectTo: '/' });

  // Fix for edit popup links
  $compileProvider.aHrefSanitizationWhitelist(/^\s*(https?|ftp|mailto|javascript):/);
}]);