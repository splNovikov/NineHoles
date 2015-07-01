/// <reference path="../libs/angular/angular.js" />

(function () {
	'use strict';

	angular
		.module('nineHoles', [
			'ui.router',

			'main'
		])

		.config([
			'$stateProvider',
			'$urlRouterProvider',

			function (
				$stateProvider,
				$urlRouterProvider) {

				var partialsPath = '/partials/';

				$urlRouterProvider.otherwise('/');

				$stateProvider
					// Main page FOR USER APPLICATION
					.state('index', {
						url: '/',
						templateUrl: partialsPath + 'main/index',
						controller: 'MainController as mainCtrl'
					})

			}])

})();