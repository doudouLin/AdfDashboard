(function () {
    'use strict';

    angular
        .module('DashboardAdmin')
        .controller('DashboardController', ['$scope', 'DashboardsFactory', function ($scope, DashboardsFactory) {
            //$scope.Dashboards = DashboardsFactory.GetAllDashboards();
            console.log($scope.Dashboards);
            var model;
            var structure = "6-6";
            var name = "InitName";
            var title = "InitTitle";

            //$scope.Dashboards.$promise.then(function (data) {
            //    console.log('am I last');

            //    console.log(data[1]);
            //    structure = data[1].structure;
            //    name = data[1].name;
            //    title = data[1].title;
            //    model = {
            //        title: data[1].title,
            //        structure: $scope.structure,
            //        rows: [{
            //            columns: [{
            //                styleClass: "col-md-4",
            //                widgets: [{
            //                    fullScreen: false,
            //                    modalSize: 'lg',
            //                    type: "clock",
            //                    config: {
            //                        timePattern: 'HH:mm:ss',
            //                        datePattern: 'YYYY-MM-DD'
            //                    },
            //                    title: "AHAHAH"
            //                }]
            //            }, {
            //                styleClass: "col-md-8",
            //                widgets: [{
            //                    fullScreen: false,
            //                    modalSize: 'sm',
            //                    type: "clock",
            //                    config: {
            //                        timePattern: 'HH:mm:ss',
            //                        datePattern: 'YYYY-MM-DD'
            //                    },
            //                    title: "Github Author"
            //                }, {
            //                    fullScreen: true,
            //                    //modalSize: 'lg',
            //                    type: "clock",
            //                    config: {
            //                        timePattern: 'HH:mm:ss',
            //                        datePattern: 'YYYY-MM-DD'
            //                    },
            //                    title: "Github History"
            //                }]
            //            }]
            //        }]
            //    };

            //});
            console.log('am I second');

            console.log(structure);
            
            $scope.structure = structure;
            $scope.name = name;
            $scope.collapsible = true;
            $scope.maximizable = true;
            $scope.categories = false;
            $scope.editable = true;
            $scope.model = model;
            var eventFired = function (event, name, model) {
                //console.log($scope.model.structure);
                console.log(event);

            };

            var widgetAddeventFired = function (event, name, model, widget) {
                //console.log($scope.model.structure);
                console.log(widget);
                console.log(model);
            };

            $scope.$on('adfDashboardChanged', eventFired);
            $scope.$on('adfWidgetAdded', widgetAddeventFired);
            $scope.$on('adfWidgetMoved', eventFired);
            $scope.$on('adfWidgetAddedToColumn', eventFired);
            $scope.$on('adfWidgetRemovedFromColumn', eventFired);
            $scope.$on('adfWidgetMovedInColumn', eventFired);
        }]);
})();
