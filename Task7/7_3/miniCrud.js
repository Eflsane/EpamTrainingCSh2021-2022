class MiniCrudDataWrapper {
    constructor(id, name, num, type) {
        if(typeof(id) != "string" || typeof(name) != "string" || typeof(num) != "number" || typeof(type) != "string") {
            console.log("exception: there is bad data. Expected: (String, String, Number, String)");
        }

        this.id = id;
        this.name = name;
        this.num = num;
        this.type = type;
    }
}

class MiniCrudService{
    _dataArray = [];

    constructor() {
    
    }

    add = (dataWrapped) => {
        if(!(dataWrapped instanceof MiniCrudDataWrapper))
        {
            console.log("exception: expected (MiniCrudDataWrapper)");
            return;
        }

        this._dataArray.push(new MiniCrudDataWrapper(dataWrapped.id, dataWrapped.name, dataWrapped.num, dataWrapped.type));
    }

    getAll = () => {
        let newDataArray = [];

        for(let i = 0; i < this._dataArray.length; i++) {
            newDataArray.push(new MiniCrudDataWrapper(
                this._dataArray[i].id,
                this._dataArray[i].name,
                this._dataArray[i].num,
                this._dataArray[i].type
                )
            );     
        }

        return newDataArray;
    }

    getById = (id) => {
        if(typeof(id) != "string")
        {
            console.log("exception: expected (String)");
            return null;
        }


        let getableData = this._dataArray.find(x => x.id == id);

        if(getableData == null)
            return null;

        let dataWrapper = new MiniCrudDataWrapper(
            getableData.id,
            getableData.name,
            getableData.num,
            getableData.type
        );  
        
        return dataWrapper
    }

    deleteById = (id) => {
        if(typeof(id) != "string")
        {
            console.log("exception: expected (String)");
            return null;
        }


        let index = this._dataArray.findIndex(x => x.id == id);

        if(index < 0)
            return null;

        let getableData = this._dataArray.splice(index, 1)[0];

        let dataWrapper = new MiniCrudDataWrapper(
            getableData.id,
            getableData.name,
            getableData.num,
            getableData.type
        ); 
         
        return dataWrapper
    }

    updateById(id, dataWrapped) {
        if(typeof(id) != "string" || !(dataWrapped instanceof MiniCrudDataWrapper))
        {
            console.log("exception: expected (String, MiniCrudDataWrapper)");
            return;
        }

        if(id != dataWrapped.id)
        {
            console.log("exception: id should be even dataWrapped.id");
            return;
        }

        let index = this._dataArray.findIndex(x => x.id == id);

        if(index < 0) 
            return;

        this._dataArray[index].name = dataWrapped.name,
        this._dataArray[index].num = dataWrapped.num,
        this._dataArray[index].type = dataWrapped.type
    }

    replaceById(id, dataWrapped) {
        if(typeof(id) != "string" || !(dataWrapped instanceof MiniCrudDataWrapper))
        {
            console.log("exception: expected (String, MiniCrudDataWrapper)");
            return;
        }

        if(id != dataWrapped.id)
        {
            console.log("exception: id should be even dataWrapped.id");
            return;
        }

        this.deleteById(id);
        this.add(dataWrapped);
    }
}