/// <reference path="D:\Documents\Visual Studio 2013\Projects\Appraisal\Appraisal\Scripts/angular.js" />

function appraisalCtl($scope, breeze) {
    // default
    var vm = $scope;
    vm.test = 'hello';
    vm.property = [];
    vm.manager = new breeze.EntityManager('breeze/appraisal');

    //CRUD

    // read
    vm.refresh = function () {
        // execute
        var query = breeze.EntityQuery.from('Property').expand('Review');
        vm.manager.executeQuery(query) // returns a promise
             .then(function (d) {
                 // process results
                 vm.property = d.results;
             });
    };

    // delete
    vm.delete = function (p) {
        p.entityAspect.setDeleted(); // mark for deletion
    };

    // add
    vm.add = function () {
        var initialValues = { Street: 'street', City: 'city', LoanOfficer: '', FormStatus: 'new' };
        vm.manager.createEntity('Property', initialValues);
    };

    // save
    vm.save = function (a) {
        vm.manager.saveChanges();
    };

    vm.refresh();
}

angular.module('appraisalApp',['breeze.angular'])
    .controller('appraisalCtl', appraisalCtl)
    .run();