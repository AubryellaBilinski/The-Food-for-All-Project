import { FoodProvider } from './FoodProvider';
import { IFoodData } from './IFoodData';

class FoodForAllProject {
    
    private foodProvider: FoodProvider;
    
    constructor(foodProvider: FoodProvider) {
        this.foodProvider = foodProvider;
    }
    
    // main method for the FoodForAllProject
    public getFoodData(): Promise<IFoodData> {
        let foodData: IFoodData;
        let promise = new Promise<IFoodData>((resolve, reject) => {
            this.foodProvider.getFoodData()
                .then(data => {
                    resolve(data);
                })
                .catch(error => {
                    reject(error);
                });
        });
    
        return promise;
    }
    
    // other methods related to FoodForAllProject
    public findFoodByName(foodName: string): Promise<IFoodData> {
        let promise = new Promise<IFoodData> ((resolve, reject) => {
            this.getFoodData().then(data => {
                let food = data.find(f => f.name === foodName);
                resolve(food);
            })
            .catch(error => {
                reject(error);
            });
        });
    
        return promise;
    }
    
    public findFoodByCategory(category: string): Promise<IFoodData[]> {
        let promise = new Promise<IFoodData[]> ((resolve, reject) => {
            this.getFoodData().then(data => {
                let foodList = data.filter(f => f.category === category);
                resolve(foodList);
            })
            .catch(error => {
                reject(error);
            });
        });
    
        return promise;
    }
}

export { FoodForAllProject };